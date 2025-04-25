document.addEventListener('DOMContentLoaded', () => {
    const searchInput = document.getElementById('searchInput');
    fetch('index.json')
        .then(response => response.json())
        .then(index => {
            searchInput.addEventListener('input', () => {
                const query = searchInput.value.toLowerCase();
                const results = index.filter(entry =>
                    entry.title.toLowerCase().includes(query)
                );
                if (results.length > 0) {
                    window.location.href = results[0].url;
                }
            });
        });
});
